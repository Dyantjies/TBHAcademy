﻿using System;
using Microsoft.EntityFrameworkCore;

namespace TBHAcademy.Models
{
    public class CalendarEvent
    {
        public int Id { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Text { get; set; }
        public string Color { get; set; }
    }
}
