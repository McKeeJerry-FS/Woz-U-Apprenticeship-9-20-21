import React from 'react';
import { render } from 'react-dom';
import Counter from './Counter';
import { Provider } from 'react-redux';
import { createStore } from 'redux';

const initialState = {
  count: 0
};

function reducer(state = initialState, action) {
  switch (action.type) {
    case 'Increment':
      return {
        count: state.count + 1
      };
    case 'IncrementByFive':
      return {
        count: state.count + 5
      };  
    case 'Decrement':
      return {
        count: state.count - 1
      };
    case 'DecrementByTen':
      return {
        count: state.count - 10
      };  
    case 'Reset':
      return {
        count: (state.count = 0)
      };
    default:
      return state;
  }
}

const store = createStore(reducer);

const App = () => (
  <Provider store={store}>
    <Counter />
  </Provider>
);

render(<App />, document.getElementById('root'));