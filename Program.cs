
using System;

public interface I1 {
    Task M1();
}

public class ClientProxy : Retrofit.IClientProxy {
    public Task SendCoreAsync(string method, object?[] args, CancellationToken cancellationToken = default) {
        Console.WriteLine($"SendCoreAsync - {method}");
        return Task.CompletedTask;
    }
}

public class P {
    public static async Task Main()
    {
        var proxy = new ClientProxy();
        var p = Retrofit.TypedClientBuilder<I1>.Build(proxy);
        await p.M1();
    }
}