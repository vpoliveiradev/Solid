namespace Solid._02_OCP.Good;

public abstract class Discount
{
    public abstract decimal Calculate(decimal price);
}

public class ElectronicsDiscount : Discount
{
    public override decimal Calculate(decimal price)
        => price * 0.5M;
}

public class HealthDiscount : Discount
{
    public override decimal Calculate(decimal price)
        => price * 0.4M;
}

public class BeautyDiscount : Discount
{
    public override decimal Calculate(decimal price)
        => price * 0.3M;
}

public class FashionDiscount : Discount
{
    public override decimal Calculate(decimal price)
        => price * 0.2M;
}