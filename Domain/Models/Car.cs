namespace Domain.Models;

public record Car(long Id, Make Make, Model Model) : Entity(Id);
