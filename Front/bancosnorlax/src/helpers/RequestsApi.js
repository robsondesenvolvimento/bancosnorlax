const getAccountsFromApi = () => {
  let arr = [];

  fetch("https://localhost:44301/api/Accounts")
    .then((response) => response.json())
    .then(resp => arr.push(...resp))
    .catch((error) => {
      console.error(error);
    });

    return arr
};

export { getAccountsFromApi };
