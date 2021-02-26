extends Node

# Handles game data for players, tiles, units & structures.

class Tile:
	var position: Vector2
	var terrain: int
	var unit: Unit
	
	func _init(_position: Vector2, _terrain: int) -> void:
		self.position = _position
		self.terrain = _terrain
	
	func set_terrain(_terrain: int) -> void:
		self.terrain = _terrain
	
	func set_unit(_unit: Unit) -> void:
		self.unit = _unit

class Unit:
	var position: Vector2
	
	func _init(_position: Vector2) -> void:
		self.position = _position
	
	func set_position(_position: Vector2) -> void:
		self.position = _position

var players: Dictionary = {}
var map_size: Vector2
var units: Array
var tiles: Array

signal fully_sinchronized

func reset() -> void:
	reset_players()

func initialize(_map_size: Vector2) -> void:
	self.map_size = _map_size
	
	for x in range(map_size.x):
		tiles.append([])
		for y in range(map_size.y):
			tiles[x].append(Tile.new(Vector2(x, y), Constants.Terrain.GRASS))

func add_player(player_id: int, player_name: String, faction: int):
	var new_player = _create_new_player(player_id, player_name, faction)
	self.players[player_id] = new_player

func get_player_name(player_id: int) -> String:
	return players[player_id].name

func reset_players() -> void:
	self.players = {}

func get_tile(at: Vector2) -> Tile:
	var tile: Tile = tiles[at.x][at.y]
	return tile

func new_unit(at: Vector2) -> Unit:
	var unit: Unit = Unit.new(at)
	units[at.x][at.y] = unit
	
	var tile: Tile = tiles[at.x][at.y]
	tile.set_unit(unit)
	
	return unit

func move_unit(from: Vector2, to: Vector2) -> void:
	if ExtendedVector2.is_in_bounds(from, map_size) == false or ExtendedVector2.is_in_bounds(to, map_size) == false:
		return
	var unit: Unit = units[from.x][from.y]
	var tile_from: Tile = tiles[from.x][from.y]
	var tile_to: Tile = tiles[to.x][to.y]
	
	unit.set_position(to)
	tile_from.set_unit(null)
	tile_to.set_unit(unit)

func get_terrain(at: Vector2) -> int:
	var tile_terrain: int = Constants.Terrain.MOUNTAINS
	if ExtendedVector2.is_in_bounds(at, map_size):
		tile_terrain = get_tile(at).terrain
	return tile_terrain

func set_terrain(at: Vector2, index: int) -> void:
	if ExtendedVector2.is_in_bounds(at, map_size):
		get_tile(at).set_terrain(index)

func _create_new_player(player_id: int, player_name: String, faction: int) -> Dictionary:
	return { 
		Constants.player_id_key: player_id, 
		Constants.player_name_key: player_name,
		Constants.player_faction_key: faction
	}

func full_synchronize() -> void:
	var _terrains: Dictionary # <String: coordinates, int: terrain>
	for x in map_size.x: 
		for y in map_size.y:
			var at := Vector2(x, y)
			_terrains[ExtendedVector2.encode_to_string(at)] = get_terrain(at)
			
	rpc("on_full_synchronize_requested", map_size, _terrains)

remote func on_full_synchronize_requested(_map_size: Vector2, _terrains: Dictionary) -> void:
	self.map_size = _map_size
	
	for x in range(map_size.x):
		tiles.append([])
		for y in range(map_size.y):
			var at_encoded: String = ExtendedVector2.encode_to_string(Vector2(x, y))
			tiles[x].append(Tile.new(Vector2(x, y), _terrains[at_encoded]))
	
	emit_signal("fully_sinchronized")
