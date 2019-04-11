import React, { Component } from 'react';
import logo from './logo.svg';
import './App.css';
import { FSComponent } from 'fs-react-sample-component'
import { CounterComponent, CounterComponent2 } from 'fs-elmish-sample-component'

class App extends Component {
  render() {
    return (
      <div className="App">
        <header className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
          <p>
            Edit <code>src/App.js</code> and save to reload.
          </p>
          <FSComponent name="from F#" />
          <CounterComponent src="https://southernfriedfsharp.com/sandwich.png" />
          <CounterComponent2 src="https://southernfriedfsharp.com/sandwich.png" />
        </header>
      </div>
    );
  }
}

export default App;
