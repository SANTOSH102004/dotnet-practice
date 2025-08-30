import React from 'react';
import ReactDOM from 'react-dom/client';
import App from './App';

// Try to mount to 'root' first (standalone React view), then 'react-app' (MVC integrated view)
const rootElement = document.getElementById('root') || document.getElementById('react-app');

if (rootElement) {
  const root = ReactDOM.createRoot(rootElement);
  root.render(
    <React.StrictMode>
      <App />
    </React.StrictMode>
  );
} else {
  console.error('React mount point not found. Looking for element with id "root" or "react-app"');
}
