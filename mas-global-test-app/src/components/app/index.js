import React, { Component } from 'react';
import Header from './components/header';
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
        <Header/>
        <p className="App-intro input-group">
          <Input
            className="App-intro__input"
            onChange={this.searchInputOnChange}
            placeholder='Search by Employee Id'
            type='number'
            value={this.state.searchInputValue}
          />
          <button className="btn btn-primary" onClick={this.searchOnClick}>
            Search
          </button>
        </p>

        {this.renderTable()}
      </div>
    );
  }
}

export default App;
