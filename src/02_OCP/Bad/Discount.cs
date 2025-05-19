using Solid._02_OCP.Enums;

namespace Solid._02_OCP.Bad;

public class Discount
{
    public decimal Calculate(EProductType type, decimal price)
    {
        if (type == EProductType.Electronics)
            return price * 0.2M;

        if (type == EProductType.Health)
            return price * 0.3M;

        if (type == EProductType.Beauty)
            return price * 0.4M;

        if (type == EProductType.Fashion)
            return price * 0.5M;

        return price;
    }
}