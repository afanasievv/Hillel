using Lesson11;
using Ninject;

class Program
{
    public static void Main()
    {
        var randomMessageBuilder = new RandomMessageBuilderModule();
        var kernel = new StandardKernel(randomMessageBuilder);
        var car = kernel.Get<IRandomMessageBuilder>();
        car.AddDateTime(true);
        car.AddGreeting();
        car.AddName();
        car.Result();

    }
}
