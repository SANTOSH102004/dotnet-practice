import React, { useState, useEffect } from 'react';
import ProductCard from './ProductCard';
import ProductForm from './ProductForm';
import Dashboard from './Dashboard';
import './ProductList.css';

const ProductList = () => {
  const [products, setProducts] = useState([]);
  const [loading, setLoading] = useState(true);
  const [error, setError] = useState(null);
  const [showForm, setShowForm] = useState(false);
  const [editingProduct, setEditingProduct] = useState(null);

  useEffect(() => {
    fetchProducts();
  }, []);

  const fetchProducts = async () => {
    try {
      setLoading(true);
      const response = await fetch('/api/products');
      if (!response.ok) {
        throw new Error('Failed to fetch products');
      }
      const data = await response.json();
      setProducts(data);
    } catch (err) {
      setError(err.message);
    } finally {
      setLoading(false);
    }
  };

  const handleAddProduct = async (productData) => {
    try {
      const response = await fetch('/api/products', {
        method: 'POST',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify(productData),
      });
      
      if (!response.ok) {
        throw new Error('Failed to add product');
      }
      
      await fetchProducts();
      setShowForm(false);
    } catch (err) {
      setError(err.message);
    }
  };

  const handleUpdateProduct = async (productData) => {
    try {
      const response = await fetch(`/api/products/${productData.id}`, {
        method: 'PUT',
        headers: {
          'Content-Type': 'application/json',
        },
        body: JSON.stringify(productData),
      });
      
      if (!response.ok) {
        throw new Error('Failed to update product');
      }
      
      await fetchProducts();
      setEditingProduct(null);
      setShowForm(false);
    } catch (err) {
      setError(err.message);
    }
  };

  const handleDeleteProduct = async (productId) => {
    if (!window.confirm('Are you sure you want to delete this product?')) {
      return;
    }

    try {
      const response = await fetch(`/api/products/${productId}`, {
        method: 'DELETE',
      });
      
      if (!response.ok) {
        throw new Error('Failed to delete product');
      }
      
      await fetchProducts();
    } catch (err) {
      setError(err.message);
    }
  };

  const handleEdit = (product) => {
    setEditingProduct(product);
    setShowForm(true);
  };

  const handleCancelForm = () => {
    setShowForm(false);
    setEditingProduct(null);
  };

  if (loading) {
    return (
      <div className="loading-container">
        <div className="spinner"></div>
        <p>Loading products...</p>
      </div>
    );
  }

  if (error) {
    return (
      <div className="error-container">
        <h2>Error</h2>
        <p>{error}</p>
        <button onClick={fetchProducts} className="btn btn-primary">
          Retry
        </button>
      </div>
    );
  }

  return (
    <div className="product-list-container">
      <Dashboard products={products} />
      
      <div className="header">
        <h1>Product Management</h1>
        <button 
          onClick={() => setShowForm(true)} 
          className="btn btn-primary"
          disabled={showForm}
        >
          Add New Product
        </button>
      </div>

      {showForm && (
        <ProductForm
          product={editingProduct}
          onSubmit={editingProduct ? handleUpdateProduct : handleAddProduct}
          onCancel={handleCancelForm}
          isEditing={!!editingProduct}
        />
      )}

      <div className="products-grid">
        {products.length === 0 ? (
          <div className="no-products">
            <p>No products found. Add your first product!</p>
          </div>
        ) : (
          products.map(product => (
            <ProductCard
              key={product.id}
              product={product}
              onEdit={handleEdit}
              onDelete={handleDeleteProduct}
            />
          ))
        )}
      </div>
    </div>
  );
};

export default ProductList;