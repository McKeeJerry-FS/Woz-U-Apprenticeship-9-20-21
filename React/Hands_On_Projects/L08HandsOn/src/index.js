import React from 'react';
import { render } from 'react-dom';

class List extends React.Component {
    shouldComponentUpdate(){
        if(this.props.items !== nextProps.items){
            return true;
        } else {
            return false;
        }
    }

    componentWillMount(){
        console.log('componentWillMount');
    }

    componentDidMount(){
        console.log('componentDidMount');
    }

    render() {
        console.log("List's render function"); // this should not be logged multiple times if the exact same props are provided a second time
    const list = this.props.items.map(item => (<li key={item}>{item}</li>));

    return (
        <ul>
            {list}
        </ul>
    );
    }
}

const list1Items = ['Eggs', 'Bread', 'Artisan cheese'];
const list2Items = ['Trains', 'Planes', 'Automobiles'];

const renderItems = (items) => {
    render(
    <List items={items} />,
    document.getElementById('root')
    );
}

document.addEventListener('keydown', event => {
    // this checks if the 1 key is pressed
    if (event.code === 'Digit1') {
        renderItems(list1Items);
    }
    // this checks if the 2 key is pressed
    else if (event.code === 'Digit2') {
        renderItems(list2Items);
    }
});

renderItems(list1Items);