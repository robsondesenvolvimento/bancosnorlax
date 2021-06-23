import logo from './logo.svg';
import './App.css';
import { GetAccountsFromApi } from './helpers/RequestsApi'
import { RequestAxios } from './helpers/RequestAxios'

function App() {
  return (
    <div className="App">
      <header className="App-header">
        <img src={logo} className="App-logo" alt="logo" />
        
        <RequestAxios />     
      </header>      
    </div>
  );
}

export default App;
