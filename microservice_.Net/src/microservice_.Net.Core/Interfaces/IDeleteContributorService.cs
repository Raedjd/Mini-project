using Ardalis.Result;

namespace microservice_.Net.Core.Interfaces;

public interface IDeleteContributorService
{
    public Task<Result> DeleteContributor(int contributorId);
}
