import React from 'react';
import ReactDOM from 'react-dom';

const App = props => {
    const favoriteCars = [
        'Honda CR-V',
        'Toyota Highlander',
        'Ford F-150',
        'BMW X3',
        'Subaru Crosstrek'
    ];
    return <List favoriteCars={favoriteCars} />; 
};

const List = props => {
    const listCars = props.favoriteCars.map((car, index) => (
        <li key={index}>{car}</li>
    ));
    return <ul>{listCars}</ul>;
}

ReactDOM.render(<App />, document.getElementById("root"));