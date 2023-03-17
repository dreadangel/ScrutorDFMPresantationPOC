namespace ScrutorLib.Services.Domain;

public record Order(Guid Id, Guid UserId, double OrderSum, string Details);