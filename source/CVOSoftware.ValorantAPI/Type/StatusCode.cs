namespace CVOSoftware.ValorantAPI.Type
{
    public enum StatusCode
    {
        Ok = 200,
        BadRequest = 400,
        Unauthorized = 401,
        Forbidden = 403,
        DataNotFound = 404,
        MethodNotAllowed = 405,
        UnsupportedMediaType = 415,
        RateLimitExceeded = 429,
        InternalServerError = 500,
        BadGateway = 502,
        ServiceUnavailable = 503,
        GatewayTimeout = 504
    }
}