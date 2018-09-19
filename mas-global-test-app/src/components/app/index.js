import React, { Component } from 'react';
import Input from './components/input';
import Table from './components/table';

import { getEmployees } from '../../actions';

import './style.css';

class App extends Component {
  constructor(props) {
    super(props);

    this.searchInputOnChange = this.searchInputOnChange.bind(this);
    this.searchOnClick = this.searchOnClick.bind(this);

    this.state = {
      searchInputValue: '',
      queryResult: []
    }
  }

  searchInputOnChange({ target }) {
    this.setState({
      searchInputValue: target.value
    });
  }

  searchOnClick(e) {
    const { searchInputValue } = this.state;

    getEmployees(searchInputValue).then(data => {
      this.setState({ queryResult: data });
    })

    e.preventDefault();
  }

  renderTable() {
    const { queryResult } = this.state;
    if (queryResult.length > 0) {
      return <Table
        data={queryResult}
        header={{
          Name:'Name',
          RoleName:'Role',
          ContractTypeName: 'Contract Type',
          HourlySalary:'Hourly Salary',
          MonthlySalary: 'Monthly Salary',
          AnnualSalary: 'Annual Salary'
        }}
      />
    }
  }

  render() {
    return (
      <div className="App">
        <header className="App-header">
          <img src="data:image/png;base64,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" />
          <h1 className="App-title">Employee Search</h1>
        </header>
        <p className="App-intro">
          <Input
            className="App-intro__input"
            onChange={this.searchInputOnChange}
            placeholder='Search by Employee Id'
            type='number'
            value={this.state.searchInputValue}
          />
          <button onClick={this.searchOnClick}>
            Search
          </button>
        </p>

        {this.renderTable()}
      </div>
    );
  }
}

export default App;
