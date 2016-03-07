using System.ComponentModel.DataAnnotations.Schema;

namespace AutoLotDAL.Models
{
    public partial class Inventory
    {
        [NotMapped]
        public string MakeColor => $"{Make} + ({Color})";

        public override string ToString()
        {
            // Since the PetName column could be empty, supply    
            // the default name of **No Name**.    
            return $"{PetName ?? "**No Name**"} is a {Color} {Make} with ID {CarId}.";
        }
    }
}