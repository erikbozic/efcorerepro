namespace EFCoreRepro;

public static class EnumUtil
{
    public static IEnumerable<TEnum> All<TEnum>()
    {
        if (!typeof(TEnum).IsEnum)
        {
            throw new ArgumentException($"{nameof(TEnum)} must be an enumerated type");
        }

        return Enum.GetValues(typeof(TEnum)).Cast<TEnum>();
    }
    
    public static string GetLiteral<TEnum>(this TEnum value) where TEnum : struct
    {
        return Enum.GetName(typeof(TEnum), value);
    }

}
