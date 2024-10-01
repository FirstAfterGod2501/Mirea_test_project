Feature: Alarm Clock
  Scenario: Trigger alarm at specified time
    Given the current time is now
    When I set the alarm to 2 seconds from now
    Then the alarm should trigger