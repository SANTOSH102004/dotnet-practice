import React from 'react';

const ProductCard = ({ product, onEdit, onDelete }) => {
  return (
    <div className="product-card">
      <div className="product-header">
        <h3 className="product-name">{product.name}</h3>
        <span className="product-category">{product.category}</span>
      </div>
      
      <div className="product-body">
        <div className="product-price">
          <span className="currency">$</span>
          <span className="amount">{product.price.toFixed(2)}</span>
        </div>
        
        <div className="product-id">
          <small>ID: {product.id}</small>
        </div>
      </div>
      
      <div className="product-actions">
        <button 
          onClick={() => onEdit(product)}
          className="btn btn-outline-primary btn-sm"
        >
          Edit
        </button>
        <button 
          onClick={() => onDelete(product.id)}
          className="btn btn-outline-danger btn-sm"
        >
          Delete
        </button>
      </div>
    </div>
  );
};

export default ProductCard;