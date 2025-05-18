import { useState } from "react";

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
     {id: 1,name: "product 1", price: 1000, is_active:true},
     {id: 2,name: "product 2", price: 2000, is_active:true},
     {id: 3,name: "product 3", price: 3000, is_active:true},
  ])

  function addProduct(){
    setProducts([...products, {id: 4,name: "product 4", price: 4000, is_active:true}])
  }

  return(
    <div>
    <h2>ProductList</h2>

    {products.map(p => (
        p.is_active && <Product key={p.name} product={p}/>
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
