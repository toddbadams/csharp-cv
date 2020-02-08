using Gateway.Application.Interfaces;

namespace Gateway.Application.Pipelines
{
    public class AuthorizedPipeline : Pipeline
    {
        internal AuthorizedPipeline(IContextFactory contextFactory, IMiddlewareFactory middlewareFactory) : base(contextFactory)
        {
            Register(middlewareFactory.CorrelationId());
            Register(middlewareFactory.FunctionHostKey());
        }
    }
}