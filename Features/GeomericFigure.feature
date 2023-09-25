Feature: Calculate area and perimeter of geometric figures

  @mytag
  Scenario Outline: Calculate area and perimeter of a square
    Given we have a square side of <Side>
    When we calculate the area and perimeter
    Then the area should be <Area>
    And the perimeter should be <Perimeter>

    Examples:
      | Side | Area | Perimeter | 
      | 5    | 25   | 20        | 
      | 10   | 100  | 40        | 
      | 7    | 49   | 28        |  # Negative side case
   
   @mytag
  Scenario Outline: Calculate area and perimeter of a triangle
    Given we have a triangle base of <BaseTriangle> and a height of <Height>
    When we calculate the area and perimeter
    Then the area should be <Area>
    And the perimeter should be <Perimeter>

    Examples:
      | BaseTriangle | Height | Area | Perimeter   |
      | 6            | 4      | 12   | 17.21       |
      | 8            | 5      | 20   | 22.43       |
      | 10           | 7      | 35   | 29.20       |


@mytag
  Scenario Outline: Calculate area and perimeter of a rhombus
    Given we have a rhombus with diagonals of lengths <MajorDiagonal> and <MinorDiagonal>
    When we calculate the area and perimeter
    Then the area should be <Area>
    And the perimeter should be <Perimeter>

    Examples:
      | MajorDiagonal  | MinorDiagonal | Area   | Perimeter |
      | 10             | 8             | 40.0   | 25.61 |
      | 12             | 9             | 54.0   | 30.0      |
      | 15             | 15            | 112.5  | 42.426406 |


       @mytag
  Scenario Outline: Calculate area and perimeter of a rectangle
    Given we have a rectangle with length <Height> and width <Width>
    When we calculate the area and perimeter
    Then the area should be <Area>
    And the perimeter should be <Perimeter>

    Examples:
      | Height | Width | Area  | Perimeter |
      | 6      | 4     | 24.0  | 20.0      |
      | 8      | 5     | 40.0  | 26.0      |
      | 10     | 7     | 70.0  | 34.0      |


  @mytag
  Scenario Outline: Calculate area and perimeter of a circle
    Given we have a circle with a radius of <Radius>
    When  we calculate the area and perimeter
    Then the area should be <Area>
    And the perimeter should be <Perimeter>

    Examples:
      | Radius | Perimeter |   Area        |
      | 5      | 78.54     | 31.42         |
      | 7      | 153.94    | 43.98         |
      | 10     | 314.16    | 62.83         |


   @mytag
  Scenario Outline: Calculate area and perimeter of an ellipse
    Given we have an ellipse with a major axis of <MajorAxis> and a minor axis of <MinorAxis>
    When we calculate the area and perimeter
    Then the area should be <Area>
    And the perimeter should be <Perimeter>

    Examples:
      | MajorAxis | MinorAxis | Area     | Perimeter |
      | 8         | 4         | 100.53   | 39.73     |
   