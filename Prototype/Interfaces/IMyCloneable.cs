namespace Prototype.Interfaces;

public interface IMyCloneable<out T>
{
    T MyClone();
}