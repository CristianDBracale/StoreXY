using StoreXY.DAL;

namespace StoreXY.DTOs
{
    public class SelectUserDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string SelectedClient { get; set; }

        public SelectUserDTO() { }

        public SelectUserDTO(Clients user)
        {
            Id = user.id;
            Name = user.name;
        }
    }
}
