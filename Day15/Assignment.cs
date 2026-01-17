using System;
using System.Linq;
using System.Collections.Generic;
public class SensorReadings
{
    public int SensorId{get;set;}
    public string Type{get;set;}
    public double Value{get;set;}
    public DateTime TimeStamp{get;set;}
    public double Confidence{get;set;}
}
public enum RobotAction
{
    Stop,SlowDown,Reroute,Continue
};
public class DecisionEngine
{
public List<SensorReadings> GetRecentReadings(List<SensorReadings> sensorHistory, DateTime fromTime)
    {
     
        return sensorHistory.Where( n => n.TimeStamp >= fromTime).ToList();
    }
    public bool IsBatteryCritical(List<SensorReadings> sr)
    {
        return sr.Any(n => n.Type == "Battery" && n.Value < 20);
    }
    public double GetNearestObstacleDistance(List<SensorReadings> readings)
    {
        return readings.Where(n => n.Type.Equals("Distance")).Select(n => n.Value).DefaultIfEmpty(double.MaxValue).Min();
    }
    public bool IsTemperatureSafe(List<SensorReadings> readings)
    {
        return readings.All(n => n.Type == "Temperature" && n.Value < 90);
    }
    public  double GetAverageVibration(List<SensorReadings> readings)
    {
        return readings.Where(n => n.Type.Equals("Vibration")).Select(n=>n.Value).DefaultIfEmpty(0).Average();
    }
    public Dictionary<string,double> CalculateSensorHealth(List<SensorReadings> readings)
    {
        return readings.GroupBy(n=> n.Type).ToDictionary(n => n.Key,n=> n.Average(n => n.Confidence));
    }
    public List<string> DetectFaultySensors(List<SensorReadings> readings)
    {
        return readings.Where(n => n.Confidence < 0.4).GroupBy(n => n.Type).Where(n => n.Count() > 2).Select(n => n.Key).ToList();
}
     public double GetWeightedDistance(List<SensorReadings> readings)
    {
    double sum = readings.Where(n => n.Type.Equals("Distance")).Sum(r => r.Value * r.Confidence);
    double d = readings.Where( n => n.Type.Equals("Distance")).Sum(r => r.Confidence);
    if(d <= 0) return double.MaxValue;
     return sum/d;
    }
    public RobotAction DecideRobotAction(List<SensorReadings> recentReadings, List<SensorReadings> sensorHistory)
    {
        if(recentReadings.Any(n => n.Type.Equals("Battery") && n.Value < 20)){ return RobotAction.Stop;}
        if(sensorHistory.Any(n => n.Type.Equals("Distance") && n.Value < 1.0)){return RobotAction.Reroute;}
        if(recentReadings.Any(n=> n.Type.Equals("Temperature") && n.Value >= 90)){return RobotAction.SlowDown;}
        return RobotAction.Continue;
    }
}

