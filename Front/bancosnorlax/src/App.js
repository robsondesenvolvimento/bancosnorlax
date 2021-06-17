import logo from './logo.svg';
import './App.css';
import { GetAccountsFromApi } from './helpers/RequestsApi'

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        
        <GetAccountsFromApi />       
      </header>      
    </div>
  );
}

export default App;
