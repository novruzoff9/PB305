$(document).ready(async function () {
  let result = await fetch("https://fakestoreapi.in/api/products");

  let res = await result.json();

  let products = res.products;

  const ul = document.getElementById("products");

  products.forEach((product) => {
    const li = document.createElement("li");
    li.innerText = product.title;
    ul.append(li);
  });

  $("#search").keyup(function () {
    let value = $(this).val();
    let filteredProducts = products.filter((x) =>
      x.title.toLowerCase().includes(value.toLowerCase())
    );
    ul.innerHTML = "";
    filteredProducts.forEach((product) => {
      const li = document.createElement("li");
      li.innerText = product.title;
      ul.append(li);
    });
  });
});
