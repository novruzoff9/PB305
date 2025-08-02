// 1.1 - Rəqəmin müsbət, mənfi və ya sıfır olduğunu yoxlayın
function checkNumber(num) {
  if (num > 0) {
    return "Müsbət";
  } else if (num < 0) {
    return "Mənfi";
  } else {
    return "Sıfır";
  }
}

// 1.2 - Yaşa görə kateqoriya təyin edin (uşaq: 0-12, yeniyetmə: 13-19, böyük: 20+)
function ageCategory(age) {
  if (age >= 0 && age <= 12) console.log("Usaqdir");
  else if (age >= 13 && age <= 19) console.log("Yeniyetme");
  else console.log("Boyuk");
}
ageCategory(19);

// 1.3 - Switch-case ilə həftənin günlərini qaytarın (1-7 arası rəqəm)
function getDayName(dayNumber) {
  switch (dayNumber) {
    case 1:
      console.log("Bazarertesi");

      break;
    case 2:
      console.log("Ikinci gun ");
      break;

    default:
      break;
  }
}
getDayName(2);

// 2.1 - 1-dən 100-ə qədər cüt ədədləri çap edin
function printEvenNumbers() {
  for (let index = 1; index < 100; index++) {
    if (index % 2 == 0) console.log(index);
  }
}
//printEvenNumbers()

// 2.2 - Ədədin faktorialını hesablayın
function factorial(n) {
  let hasil = 1;
  for (let index = 1; index <= n; index++) {
    hasil *= index;
  }
  console.log(hasil);
}
factorial(4);

// 2.3 - Fibonacci seriyasının ilk n elementini qaytarın
function fibonacci(n) {
  //0 1
  let arr = [0, 1];
  //[0, 1, 1, ..]
  for (let index = 2; index < n; index++) {
    let element = arr[index - 2] + arr[index - 1];
    arr[index] = element;
  }
  console.log(arr);
}
fibonacci(9);

// 2.4 - Ədədin rəqəmlərinin cəmini hesablayın
function digitSum(num) {  //34
    var sum=0; //12
  while(num>0){ //3
   sum+=num%10
   num=Math.floor( num/10);

  }
  console.log(sum);
  
}
digitSum(345)

// 3.1 - Array-in elementlərinin cəmini hesablayın
function sumArray(arr) {
    let something=0;
   for (let index = 0; index < arr.length; index++) {
            something+=arr[index];
    
   }
   console.log(something);
   
}
sumArray([1,2,3,4,11])

// 3.2 - Array-də müəyyən element olub-olmadığını yoxlayın
function containsElement(arr, element) {
  let has=false;
  for (let index = 0; index < arr.length; index++) {
    const elementf = arr[index];
    if(element===elementf){
        has=true
    }
  }
  console.log(has);
  
}
containsElement([1,2,3,4,11],2)

// 3.3 - Array-i tərsinə çevirin
function reverseArray(arr) {
    // Kodunuzu buraya yazın
}

// 3.4 - İki array-i birləşdirin
function mergeArrays(arr1, arr2) {
    // Kodunuzu buraya yazın
}