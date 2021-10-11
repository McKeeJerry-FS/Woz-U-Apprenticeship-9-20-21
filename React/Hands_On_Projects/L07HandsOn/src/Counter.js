import React from 'react';
import { connect } from 'react-redux';

class Counter extends React.Component {
  increment = () => {
    this.props.dispatch({
      type: 'Increment'
    });
  };

  decrement = () => {
    this.props.dispatch({
      type: 'Decrement'
    });
  };

  decrementByTen = () => {
    this.props.dispatch({
      type: 'DecrementByTen'
    });
  }

  increntByFive = () => {
    this.props.dispatch({
      type: 'IncrementByFive'
    });
  }

  reset = () => {
    this.props.dispatch({
      type: 'Reset'
    });
  };

  render() {
    return (
      <div>
        <h2>Counter</h2>
        <div>
          <span>{this.props.count}</span><br />
          <br />
          <button onClick={this.increment}>Increase By 1</button>
          <br />
          <button onClick={this.increntByFive}>Increase By 5</button>
          <br />
          <button onClick={this.decrement}>Decrease by 1</button>
          <br />
          <button onClick={this.decrementByTen}>Decrease by 10</button>
          <br />
          <button onClick={this.reset}>Reset</button>
        </div>
      </div>
    );
  }
}

function mapStateToProps(state) {
  return {
    count: state.count
  };
}

export default connect(mapStateToProps)(Counter);