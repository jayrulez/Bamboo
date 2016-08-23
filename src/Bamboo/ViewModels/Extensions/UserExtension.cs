using Bamboo.Models;

namespace Bamboo.ViewModels.Extensions
{
    public static partial class Extensions
    {
        public static UserViewModel ToViewModel(this User source)
        {
            if(source == null)
            {
                return null;
            }

            var destination = new UserViewModel();

            destination.FirstName = source.FirstName;
            destination.LastName = source.LastName;
            destination.Email = source.Email;

            return destination;
        }
    }
}
