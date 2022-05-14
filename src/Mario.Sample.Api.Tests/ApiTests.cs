using Mario.API;
using Xunit;
using static Mario.API.ApiSpecification;

namespace Mario.Sample.Api.Tests;

public class Tests: IClassFixture<ApiSpecification<Program>>
{
    private ApiSpecification<Program> API;
    public Tests(ApiSpecification<Program> api) => API = api;


    #region ApiGetSample

    [Fact]
    public Task GetProducts() =>
        API.Given(URI("/api/products"))
            .When(GET)
            .Then(OK);

    #endregion ApiGetSample


    #region ApiPostSample

    [Fact]
    public Task RegisterProduct() =>
        API.Given(
                URI("/api/products"),
                BODY(new RegisterProductRequest("abc-123", "Mario"))
            )
            .When(POST)
            .Then(CREATED);

    #endregion ApiPostSample
}
