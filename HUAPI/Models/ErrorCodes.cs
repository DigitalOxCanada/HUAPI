namespace HUAPICore.Models
{
    /// <summary>
    /// Error codes used to identify problems from a controller
    /// </summary>
    public enum ErrorCode
    {
        ItemValuesRequired,
        RecordNotFound,
        CouldNotCreateItem,
        CouldNotUpdateItem,
        CouldNotDeleteItem,
        ItemExists
    }

}
