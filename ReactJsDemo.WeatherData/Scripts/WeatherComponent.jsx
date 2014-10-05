/** @jsx React.DOM */

var WeatherGridHeaderRow = React.createClass({
	render: function() {
		return(
			<tr>
				<th>Day</th>
				<th>Max Temp.</th>
				<th>Mean Temp.</th>
				<th>Min. Temp.</th>
			</tr>
		);
	}
});

var WeatherGridRow = React.createClass({
	render: function() {
		return(
			<tr>
				<td>{this.props.day}</td>
				<td>{this.props.maxTemp}</td>
				<td>{this.props.meanTemp}</td>
				<td>{this.props.minTemp}</td>
			</tr>
		);
	}
});

var WeatherGrid = React.createClass({
	render: function() {
		var gridRows = this.props.data.items.map(function(item){
						return(
							<WeatherGridRow key={item.day} day={item.day} maxTemp={item.maxTemp} meanTemp={item.meanTemp} minTemp={item.minTemp} />
						);
					});

		return(
			<table className="table">
				<thead>
					<WeatherGridHeaderRow />
				</thead>
				<tbody>
					{gridRows}
				</tbody>
			</table>
		);
	}
});

var WeatherComponent = React.createClass({
	
	render: function() {
		return(
			<div>
				<WeatherGrid data={this.props.data} />
			</div>
		);
	}
});
