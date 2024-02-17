namespace Business.Results;
public class Result<T>
{
    public bool IsSuccess { get; }
    public T Data { get; }
    public int StatusCode { get; }
    public string ErrorMessage { get; }

    private Result(bool isSuccess, T data, int statusCode, string errorMessage)
    {
        IsSuccess = isSuccess;
        Data = data;
        StatusCode = statusCode;
        ErrorMessage = errorMessage;
    }

    public static Result<T> Success(T data)
    {
        return new Result<T>(true, data, 200, null);
    }

    public static Result<T> Failure(int statusCode, string errorMessage)
    {
        return new Result<T>(false, default, statusCode, errorMessage);
    }
}


