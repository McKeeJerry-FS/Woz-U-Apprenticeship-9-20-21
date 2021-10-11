import React from 'react';
import ReactDOM from 'react-dom';

const App = props => {
    return <NumberOfStudents /> ;
};

class NumberOfStudents extends React.Component {
    constructor(props) {
        super(props);

        this.state = {
            enrolledStudents: 87,
            waitListedStudents: 8
        };
           
    }
    
    incrementEnrolledStudentsByOne() {
        this.setState({enrolledStudents: this.state.enrolledStudents + 1 });
    }

    incrementEnrolledStudents() {
        
        this.setState({ enrolledStudents: this.state.enrolledStudents + parseInt(this.state.addAmount)});
    }

    incrementWaitListedStudentsByOne() {
        this.setState({waitListedStudents: this.state.waitListedStudenets + 1 });
            
    }

    incrementWaitListedStudents() {
        
        this.setState({ waitListedStudents: this.state.waitListedStudents + parseInt(this.state.addAmount)});
    }

    render() {
        return( 
            <div>
                <h1>Enrolled Students: {this.state.enrolledStudents}</h1>
                <button onclick={this.incrementEnrolledStudentsByOne.bind(this)}>Add 1 Enrolled Student</button>
                <h3>Add Multiple Enrolled Students</h3>
                <input type="number" onChange={event => this.setState({ addAmount: event.target.value})} value={this.state.addAmount} />
                <button onClick={this.incrementEnrolledStudents.bind(this)}>Increase Students</button><br />
                <br />
                <hr />
                <h1>Wait Listed Students: {this.state.waitListedStudents}</h1>
                <button onclick={this.incrementWaitListedStudentsByOne.bind(this)}>Add 1 Waitlisted Student</button>
                <h3>Add Multiple Waitlisted Students</h3>
                <input type="number" onChange={event => this.setState({ addAmount: event.target.value})} value={this.state.addAmount} />
                <button onClick={this.incrementWaitListedStudents.bind(this)}>Increase Students</button>
            </div>
        );
    }
}




ReactDOM.render(<App />, document.getElementById('root'));