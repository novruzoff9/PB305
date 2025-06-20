void ModifyArray(ref int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= 2; // massivin hal hazirki elementini iki qat artırır
    }
}

// Misal üçün, bu funksiyanı çağırmaq üçün:
int[] myArray = { 1, 2, 3, 4, 5 };
ModifyArray(ref myArray);
// İndi myArray massivinin bütün elementləri iki qat artırılmış olacaq: { 2, 4, 6, 8, 10 }