﻿using FBS_CoreApi.Models;

public class Flight
{
    public int Id { get; set; }
    public string FlightNumber { get; set; }
    public string DepartureAirport { get; set; }
    public string ArrivalAirport { get; set; }
    public DateTime DepartureTime { get; set; }
    public DateTime ArrivalTime { get; set; }
    public decimal Price { get; set; }
    public List<CabinClass> CabinClasses { get; set; }
}