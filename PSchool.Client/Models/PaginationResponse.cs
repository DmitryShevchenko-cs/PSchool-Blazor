namespace PSchool.Client.Models;

public class PaginationResponse<T> 
{
    public IEnumerable<T> Data { get; set; } = null!;
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public int TotalItems { get; set; }
    public int TotalPages { get; set; }
    
    public PaginationResponse(List<T> data, int count, int pageNumber, int pageSize)
    {
        PageNumber = pageNumber;
        PageSize = pageSize;
        TotalItems = count;
        TotalPages = (int)Math.Ceiling(count / (double)pageSize);
        Data = data;
    }
    
    public PaginationResponse() { }
}