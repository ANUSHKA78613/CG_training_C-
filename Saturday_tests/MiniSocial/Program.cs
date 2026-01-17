using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;
using System.IO;
using System.Text.Json;
using MiniSocialMedia;
 class Program
{
    public static readonly Repository<User> _users = new();
    private static User?_currentUser = null;
    private static readonly string _dataFile = "Social-data.json";
    public static void Main()
    {
        Console.Title = "MiniSocial - Console Edition";
        Console.WriteLine("=== MiniSocial ===");
        LoadData();
        while (true)
            {
                try
                {
                    if (_currentUser == null)
                    {
                        ShowLoginMenu();
                    }
                    else
                    {
                        ShowMainMenu();
                    }
                }
                catch (SocialException ex)
                {
                    ConsoleColor originalColor = Console.ForegroundColor;
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine($"Error: {ex.Message}");

                    if (ex.InnerException != null)
                    {
                        Console.WriteLine(ex.InnerException.Message);
                    }

                    Console.ForegroundColor = originalColor;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Unexpected Error!!");
                    Console.WriteLine(ex);
                    LogError(ex);
                }
                 Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey(true);
                Console.Clear();
    }

    }
 
   public static void ShowLoginMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("\n1.Register \n 2.Login \n 0. Exit\n");
            Console.WriteLine("enter your choice: ");
            choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: Register();
                break;
                case 2: Login();
                break;
                case 0: break;
                default : Console.WriteLine("Invalid choice");
                break;
            }
        }while(choice != 0);
    }
    public static void Register()
    {
        Console.WriteLine("Enter username: ");
        string username = Console.ReadLine();
        Console.WriteLine("Enter user email: ");
        string email = Console.ReadLine();
       if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(email))
        throw new ArgumentException("Username and email are required");
        if(_users.Find(u => string.Equals(u.Username,username.Trim(),StringComparison.OrdinalIgnoreCase))!=null)
         throw new SocialException("Username already exists");
         User user = new(username,email);
         _users.Add(user);
         Console.WriteLine($"Welcome, {user.Username}!");
    }
    public static void Login()
    {
        Console.WriteLine("Enter the username: ");
        string username = Console.ReadLine();
  User? user = _users.Find(u =>
                string.Equals(u.Username, username, StringComparison.OrdinalIgnoreCase));

            if (user == null)
                throw new SocialException("User not found");

_currentUser.OnNewPost += post =>
{
    var prev = Console.ForegroundColor;
    Console.ForegroundColor = ConsoleColor.Cyan;

    string preview = post.Content.Length > 40
        ? post.Content.Substring(0, 40) + "..."
        : post.Content;

    Console.WriteLine($"[New Post] {post.Author.Username}: {preview}");

    Console.ForegroundColor = prev;
};
} 
 private static void ShowMainMenu()
    {
        int choice;
        do
        {
            Console.WriteLine("\n1.Post messages \n 2.View my posts  \n 3. View timeline(feed) 4. Follow user\n 5.List users\n 6. Logout 0. Exit & save\n");
            Console.WriteLine("enter your choice: ");
             choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1: PostMessage();
                break;
                case 2: ShowPosts(_currentUser.GetPosts());
                break;
                case 3: ShowTimeline();
                break;
                case 4:  FollowUser();
                break;
                case 5:  ListUsers();
                break;
                case 6: _currentUser = null;
                Console.WriteLine("Logged out successfully.");
                break;
                case 0: SaveData();
                break;
                default : Console.WriteLine("Invalid choice");
                break;
            }
        }while(choice != 0);
    }  
    public static void PostMessage()
    {
        if(_currentUser == null) return;
    Console.WriteLine("Write your post (max 280 characters).");
    Console.WriteLine("Leave empty to cancel.");
    Console.Write("Post: ");
      string? content = Console.ReadLine();
    content = content?.Trim();
    if (string.IsNullOrWhiteSpace(content))
    {
        Console.WriteLine("Post cancelled.");
        return;
    }
    _currentUser.AddPost(content);
    Console.WriteLine("Post published successfully.");
    }

    public static void ShowTimeline()
    {
        if(_currentUser == null) return;
        List<Post> timeline = new List<Post>();
        timeline.AddRange(_currentUser.GetPosts());
        foreach(var name in _currentUser.GetFollowingNames())
    {
        var user=_users.Find(u=>string.Equals(u.Username,name,StringComparison.OrdinalIgnoreCase));
        if(user!=null) timeline.AddRange(user.GetPosts());
    }
    timeline=timeline.OrderByDescending(p=>p.CreatedAt).ToList();
    Console.WriteLine("=== Your Timeline ===");
    ShowPosts(timeline);
    }
    private static void ShowPosts(IEnumerable<Post> posts)
    {
         int count = 0;

    foreach (var post in posts)
    {
        if (count == 20)
            break;
       Console.WriteLine(post);
       Console.WriteLine(post.CreatedAt.FormatTimeAgo());
       Console.WriteLine(new string('-', 40));
        count++;
    }
  if (count == 0)
    {
        Console.WriteLine("No posts yet.");
    }
}
public static void FollowUser()
    {
         if(_currentUser == null) return;
         Console.Write("Enter username to follow: ");
         string? targetUsername = Console.ReadLine()?.Trim();
           if (string.IsNullOrWhiteSpace(targetUsername))
    {
        Console.WriteLine("Cancelled.");
        return;
    }
     if (string.Equals(_currentUser.Username, targetUsername, StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine("You cannot follow yourself.");
        return;
    }
     User? targetUser = _users.Find(u =>
        string.Equals(u.Username, targetUsername, StringComparison.OrdinalIgnoreCase));

    if (targetUser == null)
    {
        Console.WriteLine("User not found.");
        return;
    }
     _currentUser.Follow(targetUsername);
      Console.WriteLine($"Now following @{targetUsername}");
    }
    public static void ListUsers()
    {
        Console.WriteLine("Registered users: ");
         var users = _users.GetAll();
          var sortedUsers = users
        .OrderBy(u => u.Username, StringComparer.OrdinalIgnoreCase);
         foreach (var user in sortedUsers)
    {
        Console.WriteLine(
            $"{("@" + user.Username).PadRight(20)} {user.Email}"
        );
    }
}
public static void SaveData()
{
    try
    {
        var data=_users.GetAll().Select(u=>new{
            Username=u.Username,
            Email=u.Email,
            Following=u.GetFollowingNames(),
            Posts=u.GetPosts().Select(p=>new{
                Content=p.Content,
                CreatedAt=p.CreatedAt
            }).ToList()
        }).ToList();
        string json=JsonSerializer.Serialize(data,new JsonSerializerOptions{WriteIndented=true});
        File.WriteAllText(_dataFile,json);
        Console.WriteLine("Data saved.");
    }
    catch(Exception ex)
    {
        LogError(ex);
        Console.WriteLine("Failed to save data.");
    }   
}
public static void LoadData()
{
    try
    {
        if(!File.Exists(_dataFile)) return;
        string json=File.ReadAllText(_dataFile);
        if(string.IsNullOrWhiteSpace(json)) return;
        var data=JsonSerializer.Deserialize<List<object>>(json);
        Console.WriteLine("Data loaded (simulation - add proper logic).");
    }
    catch(Exception ex)
    {
        LogError(ex);
        Console.WriteLine("Failed to load data.");
    }
}
static void LogError(Exception ex)
{
    try
    {
        string log=$"{DateTime.Now}\n{ex.Message}\n{ex.StackTrace}\n--------------------\n";
        File.AppendAllText("error.log",log);
    }
    catch{}
}
private static void ConsoleColorWrite(ConsoleColor color,string text)
{
    var prev=Console.ForegroundColor;
    Console.ForegroundColor=color;
    Console.WriteLine(text);
    Console.ForegroundColor=prev;
}
}
   public static class UserExtensions
    {
        // Normally you'd add private field, but for demo:
        public static IEnumerable<string> GetFollowingNames(this User user)
        {
            // Reflection or better design needed in real code - here we simulate
            // In full version: add private HashSet to User
            return Enumerable.Empty<string>(); // Placeholder - extend User class
        }
    }

