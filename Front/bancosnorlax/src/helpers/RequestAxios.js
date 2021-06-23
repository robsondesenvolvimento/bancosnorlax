import React from 'react';
import axios from 'axios';

class RequestAxios extends React.Component {
    state = {
        accounts: []
    }

    componentDidMount() {
        axios.get('https://localhost:44301/api/accounts')
        .then(res => {
            const accounts = res.data;
            this.setState({ accounts });
        });
    }
    
    render() {
        return (
            <ul>
                {this.state.accounts.map(account => <li>Id: {account.id} Agency: {account.agency} Account: {account.number} Sale: {account.sale}</li>)}
            </ul>
        );
    }
}

export { RequestAxios }
