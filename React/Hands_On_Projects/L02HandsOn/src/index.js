import React from 'react';
import ReactDOM from 'react-dom';

const stateInfo = (item1, item2, item3, item4, item5, item6, item7, item8, item9, item10, item11, item12) => {
    return (
        
      <table>
          <thead>
            <th>State</th>
            <th>Population</th>
          </thead>
          <tr>
            <td>{item1}</td>
            <td>{item2}</td>
          </tr>
          <tr>
            <td>{item3}</td>
            <td>{item4}</td>
          </tr>
          <tr>
            <td>{item5}</td>
            <td>{item6}</td>
          </tr>
          <tr>
              <td>{item7}</td>
              <td>{item8}</td>
          </tr>
          <tr>
              <td>{item9}</td>
              <td>{item10}</td>
          </tr>
          <tr>
              <td>{item11}</td>
              <td>{item12}</td>
          </tr>
      </table>
    );
  };

  ReactDOM.render(
    stateInfo('Connecticut', '3,565,287', 'Massachusetts', '6,892,503', 'Rhode Island', '1,059,361', 'Vermont', '623,989', 'New Hampshire', '1,359,711', 'Maine', '1,344,212'),
    document.getElementById('root')
  );
  