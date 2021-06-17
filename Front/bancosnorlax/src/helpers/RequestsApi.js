import React, { useState, useEffect } from 'react';

function GetAccountsFromApi() {
  const [error, setError] = useState(null);
  const [isLoaded, setIsLoaded] = useState(false);
  const [items, setItems] = useState([]);

  // Nota: O array [] deps vazio significa
  // este useEffect será executado uma vez
  // semelhante ao componentDidMount()
  useEffect(() => {
    fetch("https://localhost:44301/api/accounts")
      .then(res => res.json())
      .then(
        (result) => {
          setIsLoaded(true);
          setItems(result);
        },
        // Nota: é importante lidar com errros aqui
        // em vez de um bloco catch() para não receber
        // exceções de erros reais nos componentes.
        (error) => {
          setIsLoaded(true);
          setError(error);
        }
      )
  }, [])

  if (error) {
    return <div>Error: {error.message}</div>;
  } else if (!isLoaded) {
    return <div>Loading...</div>;
  } else {
    return (
      <div>
        {items.map(item => (
          <p>
            Id: {item.id} Agency: {item.agency} Account: {item.number} Sale: {item.sale}
          </p>
        ))}
      </div>
    );
  }
}

export { GetAccountsFromApi };
