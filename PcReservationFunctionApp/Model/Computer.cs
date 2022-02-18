﻿using System;
using Azure;
using Azure.Data.Tables;

namespace PcReservationFunctionApp.Model;

public class Computer : ITableEntity
{
    public string DeviceId { get; set; }
    public string IpAddress { get; set; }
    public string MacAddress { get; set; }
    public string MachineName { get; set; }

    public string PartitionKey { get; set; }
    public string RowKey { get; set; }
    public DateTimeOffset? Timestamp { get; set; }
    public ETag ETag { get; set; }
}