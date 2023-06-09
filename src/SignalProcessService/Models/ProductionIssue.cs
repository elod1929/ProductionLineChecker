namespace SignalProcessService.Models;

public record struct ProductionIssue(
  string ProductId, 
  string ProductName, 
  string ProductionLineId, 
  int Delay, 
  DateTime Timestamp,
  DateTime StartTimestamp,
  DateTime EndTimestamp
);