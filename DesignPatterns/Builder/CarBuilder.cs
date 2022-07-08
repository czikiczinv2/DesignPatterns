namespace DesignPatterns.Builder;

public abstract class CarBuilder
{
    public abstract void  BuildEngineAndInterior();
    
    public abstract void BuildWheels();
    
    public abstract void BuildTires();

    public abstract void BuildSteeringWheel();

    public abstract void BuildCarBody();

    public virtual void BuildRadio()
    {
        
    }

    public virtual void BuildAirConditioning()
    {
        
    }

    public virtual void BuildTurbo()
    {
        
    }

    public virtual void BuildSpoiler()
    {
        
    }

    public virtual void BuildTrailer()
    {
        
    }
}