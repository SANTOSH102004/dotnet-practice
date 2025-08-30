import React from 'react';
import ProductList from './components/ProductList';
import './App.css';

function App() {
  return (
    <div className="app">
      <header className="app-header">
        <div className="container">
          <h1>ReactMVC Product Management</h1>
          <p>A modern React + ASP.NET Core MVC application</p>
        </div>
      </header>
      
      <main className="app-main">
        <div className="container">
          <ProductList />
        </div>
      </main>
      
      <footer className="app-footer">
        <div className="container">
          <p>&copy; 2025 ReactMVC App. Built with React and ASP.NET Core.</p>
        </div>
      </footer>
    </div>
  );
}

export default App;
