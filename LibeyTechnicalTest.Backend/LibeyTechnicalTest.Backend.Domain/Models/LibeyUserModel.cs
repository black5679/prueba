namespace LibeyTechnicalTest.Backend.Domain.Models
{
    public class LibeyUserModel
    {
        public string? DocumentNumber { get; private set; }
        public int DocumentTypeId { get; private set; }
        public string Name { get; set; }
        public string FathersLastName { get; set; }
        public string MothersLastName { get; set; }
        public string Address { get; set; }
        public string UbigeoCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string? Password { get; set; }
        public bool Active { get; set; }
        public LibeyUserModel(string? documentNumber, int documentTypeId, string name, string fathersLastName, string mothersLastName, string address,
        string ubigeoCode, string phone, string email, string? password)
        {
            DocumentNumber = documentNumber;
            DocumentTypeId = documentTypeId;
            Name = name;
            FathersLastName = fathersLastName;
            MothersLastName = mothersLastName;
            Address = address;
            UbigeoCode = ubigeoCode;
            Phone = phone;
            Email = email;
            Password = password;
            Active = true;
        }
    }
}
