﻿using System.Collections.Generic;

namespace HomeFinder.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public List<RegistrationOfInterest> Registrations { get; set; }
    }
}
