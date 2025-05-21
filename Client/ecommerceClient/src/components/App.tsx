import { useEffect, useState } from "react";
import { IProduct } from "../model/IProduct";
import Header from "./Header";
import ProductList from "./ProductList";

function App() {

  const  [products, setProducts] = useState<IProduct[]>([])

  useEffect(() => {
  fetch("https://localhost:7017/api/Products")
  .then(response => response.json())
  .then(data => setProducts(data));
  }, []);
 

  function addProduct(){
    setProducts([...products, 
      {
        id: 4,
        name: "product 4",
        price: 4000, 
        isActive:true       
        }])
  }


  return (
    <>
    <Header products={products}/>
    <ProductList products={products} addProduct={addProduct}/>
    </>
  );
}

export default App
