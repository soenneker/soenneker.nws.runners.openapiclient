using Soenneker.Tests.HostedUnit;

namespace Soenneker.Nws.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class NwsOpenApiClientRunnerTests : HostedUnitTest
{
    public NwsOpenApiClientRunnerTests(Host host) : base(host)
    {

    }

    [Test]
    public void Default()
    {

    }
}
