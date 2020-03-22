using System.ComponentModel.DataAnnotations.Schema;

namespace EFStudiuDeCaz.Business
{
    [Table("eCommerce", Schema = "BazaDeDate")]
    public class eCommerce : Business
    {
        public string URL { get; set; }
    }

}
