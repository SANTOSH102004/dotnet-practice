# ReactMVC App

A modern web application that combines React frontend with ASP.NET Core MVC backend, demonstrating full-stack development with CRUD operations.

## Features

- **React Frontend**: Modern React components with hooks and state management
- **ASP.NET Core MVC Backend**: RESTful API endpoints for product management
- **Webpack Integration**: Bundling and hot-reload development
- **CRUD Operations**: Complete Create, Read, Update, Delete functionality
- **Responsive Design**: Mobile-friendly UI with modern styling
- **Form Validation**: Client-side validation with error handling

## Project Structure

```
ReactMvcApp/
├── Controllers/
│   └── HomeController.cs          # MVC controller with API endpoints
├── Models/
│   └── ErrorViewModel.cs          # Error handling model
├── Views/
│   ├── Home/
│   │   ├── Index.cshtml           # MVC integrated React view
│   │   ├── React.cshtml           # Standalone React view
│   │   └── Privacy.cshtml         # Privacy page
│   └── Shared/
│       └── _Layout.cshtml         # Shared layout
├── src/
│   ├── components/
│   │   ├── ProductList.js         # Main product management component
│   │   ├── ProductList.css        # Component styling
│   │   ├── ProductCard.js         # Individual product display
│   │   └── ProductForm.js         # Add/Edit product form
│   ├── App.js                     # Main React application
│   ├── App.css                    # Global styles
│   ├── index.js                   # React entry point
│   └── index.html                 # HTML template
├── wwwroot/
│   └── dist/                      # Webpack output directory
├── webpack.config.js              # Webpack configuration
├── .babelrc                       # Babel configuration
└── package.json                   # NPM dependencies and scripts
```

## Getting Started

### Prerequisites

- .NET 9.0 SDK
- Node.js 18+ and npm

### Installation

1. **Restore .NET packages:**
   ```bash
   dotnet restore
   ```

2. **Install npm dependencies:**
   ```bash
   npm install
   ```

3. **Build React application:**
   ```bash
   npm run build
   ```

### Development

1. **Start the ASP.NET Core server:**
   ```bash
   dotnet run
   ```

2. **In a separate terminal, start React development with hot reload:**
   ```bash
   npm run dev
   ```

3. **Access the application:**
   - MVC integrated view: `https://localhost:5001/`
   - Standalone React view: `https://localhost:5001/Home/React`
   - React dev server: `http://localhost:3000` (with API proxy)

## API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| GET | `/api/products` | Get all products |
| GET | `/api/products/{id}` | Get product by ID |
| POST | `/api/products` | Create new product |
| PUT | `/api/products/{id}` | Update existing product |
| DELETE | `/api/products/{id}` | Delete product |

## Usage

### Product Management

- **View Products**: All products are displayed in a responsive grid
- **Add Product**: Click "Add New Product" to open the form
- **Edit Product**: Click "Edit" on any product card
- **Delete Product**: Click "Delete" with confirmation dialog
- **Form Validation**: Real-time validation with error messages

### Integration Options

1. **MVC Integration**: React components embedded in MVC views
2. **Standalone React**: Full React SPA with MVC API backend
3. **Hybrid Approach**: Mix of server-rendered and client-rendered content

## Technologies Used

- **Frontend**: React 19, Webpack 5, Babel, CSS3
- **Backend**: ASP.NET Core 9.0, C#
- **Development**: Hot Module Replacement, Source Maps
- **Styling**: Modern CSS with Flexbox and Grid