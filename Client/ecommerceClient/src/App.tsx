import { useEffect, useState } from "react";

function App() {

  return (
    <>
    <Header/>
    <ProductList/>
    </>
  );
}

function Header(){
  return (
    <h1>Header</h1>
  );
}

function ProductList(){

  const  [products, setProducts] = useState([
     {id: 1,name: "product 1", price: 1000, isActive:true},
     {id: 2,name: "product 2", price: 2000, isActive:true},
     {id: 3,name: "product 3", price: 3000, isActive:true},
  ])

  useEffect(() => {
  fetch("https://localhost:7017/api/Products")
  .then(response => response.json())
  .then(data => setProducts(data));
  }, []);
 

  function addProduct(){
    setProducts([...products, {id: 4,name: "product 4", price: 4000, isActive:true}])
  }

  return(
    <div>
    <h2>ProductList</h2>

    {products.map(p => (
        p.isActive && <Product key={p.name} product={p}/>
    ))}

   <button onClick={ addProduct }>Add Product</button>
    </div>
  );
}

function Product(props: any){
  return(
    <div>
      <h3>{props.product.name}</h3> <p>{props.product.price}</p>
    </div>
  );
}

export default App
