using System.ComponentModel;

namespace Supermarket.API.Domain.Models
{
    public enum EUnitOfMeasurement
    {
        [Description("UN")]
        Unity = 1,
        [Description("MG")]
        Millgram = 2,
        [Description("G")]
        Gram = 3,
        [Description("KG")]
        Kilogram = 4,
        [Description("L")]
        Liter = 5
    }
}