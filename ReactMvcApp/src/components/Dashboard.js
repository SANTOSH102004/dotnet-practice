import React, { useState, useEffect } from 'react';

const Dashboard = ({ products }) => {
  const [stats, setStats] = useState({
    totalProducts: 0,
    totalValue: 0,
    categories: {},
    avgPrice: 0
  });

  useEffect(() => {
    if (products && products.length > 0) {
      const totalProducts = products.length;
      const totalValue = products.reduce((sum, product) => sum + product.price, 0);
      const avgPrice = totalValue / totalProducts;
      
      const categories = products.reduce((acc, product) => {
        acc[product.category] = (acc[product.category] || 0) + 1;
        return acc;
      }, {});

      setStats({
        totalProducts,
        totalValue,
        categories,
        avgPrice
      });
    }
  }, [products]);

  return (
    <div className="dashboard">
      <h2>Dashboard Overview</h2>
      <div className="stats-grid">
        <div className="stat-card">
          <div className="stat-value">{stats.totalProducts}</div>
          <div className="stat-label">Total Products</div>
        </div>
        
        <div className="stat-card">
          <div className="stat-value">${stats.totalValue.toFixed(2)}</div>
          <div className="stat-label">Total Value</div>
        </div>
        
        <div className="stat-card">
          <div className="stat-value">${stats.avgPrice.toFixed(2)}</div>
          <div className="stat-label">Average Price</div>
        </div>
        
        <div className="stat-card">
          <div className="stat-value">{Object.keys(stats.categories).length}</div>
          <div className="stat-label">Categories</div>
        </div>
      </div>
      
      {Object.keys(stats.categories).length > 0 && (
        <div className="categories-breakdown">
          <h3>Products by Category</h3>
          <div className="category-list">
            {Object.entries(stats.categories).map(([category, count]) => (
              <div key={category} className="category-item">
                <span className="category-name">{category}</span>
                <span className="category-count">{count} products</span>
              </div>
            ))}
          </div>
        </div>
      )}
    </div>
  );
};

export default Dashboard;