namespace WinForms2Home
{
    class Anket
    {
        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? FatherName { get; set; }
        public string? Country { get; set; }
        public string? City { get; set; }
        public string? Phone { get; set; }
        public string? Gender { get; set; }

        public DateTime Birthday { get; set; }

        public Anket(string? surname, string? name, string? fatherName,
            string? country, string? city, string? phone,
            string? gender, DateTime birthday)
        {
            Surname = surname;
            Name = name;
            FatherName = fatherName;
            Country = country;
            City = city;
            Phone = phone;
            Gender = gender;
            Birthday = birthday;
        }
    }
}