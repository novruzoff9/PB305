using SoftDelete.Exceptions;
using SoftDelete.Interfaces;

namespace SoftDelete.Extensions;

public static class SoftDeleteHelper
{
    public static void SoftDelete<T>(this List<T> items, T deletedItem) 
        where T : ISoftDeletable
    {
        foreach (var item in items)
        {
            if (item.Equals(deletedItem))
            {
                item.IsDeleted = true;
                return;
            }
        }
        throw new NotFoundException();
    }
    public static void SoftDeleteMany<T>(this List<T> items, Func<T, bool> predicate) where T : ISoftDeletable
    {
        List<T> deletedItems = items.Where(predicate).ToList();
        deletedItems.ForEach(x => x.IsDeleted = true);
    }

    public static List<T> GetActiveItems<T>(this List<T> items)
        where T : ISoftDeletable
    {
        var result = items.Where(x => !x.IsDeleted).ToList();
        return result;
    }

    public static List<T> GetActiveItems<T>(this List<T> items, Func<T, bool> predicate)
        where T : ISoftDeletable
    {
        if (predicate == null)
        {
            return GetActiveItems(items);
        }
        var filteredItems = items.Where(predicate).ToList();
        var result = filteredItems.Where(x => !x.IsDeleted).ToList();
        return result;
    }
}
